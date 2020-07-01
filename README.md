Profile manager
===

An Autodesk Inventor add-in that allows the user to create and manage settings "profiles"; these are akin to profiles in Autocad.  Users can save their current settings as a profileand reload profiles at a later date.


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