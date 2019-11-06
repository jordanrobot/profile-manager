Profile mangaer
===

Create an add-in that allows the Inventor User to create settings "profiles".  These are akin to profiles from autocad.  This may be useful for users who are freelance inventor users who have to use the software to match client configurations.

* User configures Inventor as required.  This can include:  
	* Application Options
	* Project files???
	* current project file
	* iLogic Path directories
* User opens the profile switcher dialogue.
* User can create and activate a profile for the current setup.
* Does the user have to explicity save the profile, or do we read the profile at the next load?
* Changes the user makes will now save to that profile.
* The user can change profiles at any time, changing the set of Inventor configuration options.

Structure
---

user opens the profile manager dialog

where are these profiles stored?  How are they access?

Each is created as a profile object, they are stored in a profile object collection.
Where is this data stored across user sessions?  How is it serialized?
User options?


* ProfileCollection <Collection> or use as generic list of Profile objects?
	+ Item
	+ Add
	+ Remove


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

* ProjectOptions <Object> + IOptionsObject
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


Options
===

Look at using Inventor's Application.___Options as basis for grouping my options in the ApplicationOptions object?
Use an interface to define the basic structure of each?
Or write a clone/deep-copy method, and clone each ___Options object and use clone as the data-source for later recall?

* [X] ContentCenterOptions
* [ ] DisplayOptions
* [ ] DrawingOptions
* [ ] FileOptions
* [X] GeneralOptions
* [ ] HardwareOptions
* [ ] iFeatureOptions
* [ ] InventorVBAProjects???
* [ ] NotebookOptions
* [ ] PartOptions
* [ ] SaveOptions
* [ ] Sketch3DOptions
* [ ] SketchOptions


* IOptionObject
	+ 
	- 
	---
	+ New (CurrentOptionObject As Object) :
	+ GetOptions (CurrentOptionObject)
	+ SetOptions (CurrentOptionObject)

