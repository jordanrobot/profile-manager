
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