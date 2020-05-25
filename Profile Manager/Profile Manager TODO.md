Profile manager
===

An Autodesk Inventor add-in that allows the user to create and manage settings "profiles"; these are akin to profiles in Autocad.

#### Why would I use this?

* As a freelancer, set up profiles for different clients, where each client provides ifeature libraries, specific settings, ilogic paths, default vba project, etc
* Load seperate sets of project files, say for clients, or 
* Set up different profiles for performance reasons.  E.g.
  * presentations and high-quality reviews,
  * optimized performance,
  * Enable performance settings when on battery power, or plugged into an egpu.
* Set up profiles for different users on the same windows or autodesk login.

    But inventor lets me import and export my application settings.  Why not use that?

This tool is quicker to use, and manages the profile locations for you; no more digging into folders to find the xml files to import or export.  It's as easy as opening the Profile Manager dialogue and selecting the profile you want to use.  This tool also manages ilogic configuration paths, something the Application Options import/export does not do.

#### Usage

* User configures Inventor as required.  This can include:  
	* Application Options
	* Project files???
	* current project file
	* iLogic Path directories
* User opens the profile switcher dialogue.
* User can create and activate a profile for the current setup.
* The user has to explicity save the profile
* if the user options changes, an event watcher sets a "dirty" flag, this will notify the user that the profile is not saved.
* The user can change profiles at any time, changing the set of Inventor configuration options.
* If a file is loaded, we will not be able to change the project files.  Maybe we leave theses alone?
* look at a way to edit the file name generator settings
* Opionally, make able to slave/associate to a project?  That way when you change projects, it changes your profile?



Structure
---

user opens the profile manager dialog

where are these profiles stored?  How are they accessed?
	Store into Inventor's options xml file?
    Or serialize seperately?

Each is created as a profile object, they are stored in a profile object collection.
Where is this data stored across user sessions?  How is it serialized?
User options?

Data Load object
	+ load data (data): returns a ProfileCollection
	+ save data (profileCollection): returns a serialized data stream? 
	Import Profile????
	Export Profile?????

[X] ProfileCollection
	+ Item
	+ Add
	+ Remove
	+ Name (return profile by name)


* Profile <Object>
	+ Name <String>
	- applicationOptions <ApplicationOptions>
	- iLogicPathSettings <List of String>
	- projectOptions <ProjectOptions>
	---
	+ New(Name As <String>) : <Profile>
		- Creates the profile
		- Calls SaveProfile
	+ SaveProfile : <Boolean>
		- gets the current Inventor User options by...
		- calling the Get___ methods in each property object, this updates the data in those objects
		- Returns a boolean to indicate status of the operation
	+ LoadProfile : <Boolean>
		- saves the current Inventor User options in the selected profile by...
		- calling the Set___ methods in each property object, this updates the application options
		- Returns a boolean to indicate the status of the operation

		User interaction:
			Create New
			Duplicate
			Delete
			Save Profile
			Make Active
			Import Profile????
			Export Profile?????

* Inventor.SpellCheckOptions
	- Add this!!!

* ApplicationOptions <Object>
	+ List as a hash-table (different types?)
		- Option 1 : value
		- Option 2 : value
		- Option 3 : value
	---
	+ New : <ApplicationOptions>
	+ GetOptions : <boolean>
		- Gets each option from Inventor and saves it to the hash table
	+ SetOptions : <boolean>
		- Gets each option from the hash table and saves it to Inventor

* iLogicPathSettings <Object> : IOptionsObject
	- Paths <List of Strings>
	---
	+ New : <iLogicPathSettings>
	+ GetPathSettings : <Boolean>
	+ SetPathSettings : <Boolean>

* ProjectOptions <Object> + IOptionsObject  ???????? OR NOT DO THIS ONE???
	- Projects <List of Strings>
	- CurrentProject <>
	---
	+ New : <ProjectFileOptions>
	+ Getprojects : <Boolean>
		- Gets each Project reference from Inventor and saves it to the Projects list
		- mechanism: for each in DesignProjects - save FullFileName to list
	+ SetProjects : <Boolean>
		- Gets each Project reference from the Projects list and saves it to Inventor
		- mechanism: Application.DesignProjects.AddExisting( FullFileName As String )


Option Groups
===

* [X] ContentCenterOptions
* [X] DisplayOptions
* [X] DrawingOptions
* [X] FileOptions
* [X] GeneralOptions
* [X] HardwareOptions
* [X] iFeatureOptions
* [X] NotebookOptions
* [X] PartOptions
* [X] SaveOptions
* [X] Sketch3DOptions
* [X] SketchOptions

Detect User Changes to Application Options
===

Create a handler to watch for the Inventor.ApplicationEventsSink_OnApplicationOptionChangeEventHandler event.
Put this in an object????  RESEARCH HANDLERS MORE!
Define a "dirty" boolean variable.  When the options change, make this variable True.
This will let us indicate to the user that the options have been changed since the last save of the currently active Profile.