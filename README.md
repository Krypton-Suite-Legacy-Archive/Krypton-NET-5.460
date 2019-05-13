# <img src="https://github.com/Wagnerp/Krypton-NET-5.460/blob/master/Assets/PNG/Square%20Design/Main%20Icon/64%20x%2064/Square%20Design%2064%20x%2064%20New%20Green.png"> .NET 5.460

=======

| NuGet | Current NuGet Version | NuGet Downloads | Github License |
|---|---|---|---|
| [![NuGet](https://img.shields.io/badge/NuGet-Krypton%20.NET%205.460-green.svg)](https://www.nuget.org/packages/KryptonToolkitSuite5460/) | ![Nuget](https://img.shields.io/nuget/v/KryptonToolkitSuite5460.svg) | ![Nuget](https://img.shields.io/nuget/dt/KryptonToolkitSuite5460.svg?color=blue&label=NuGet%20Downloads) | ![GitHub](https://img.shields.io/github/license/Wagnerp/Krypton-NET-5.460.svg) |

=======

# <img src="https://github.com/Wagnerp/Krypton-NET-5.470/blob/master/Assets/PNG/Help/Help_1_48_x_48.png" /><a href="https://wagnerp.github.io/Krypton-NET-5.470/Help/Output/index.html">Online Help</a>

=======

# <img src="https://github.com/Wagnerp/Krypton-NET-Version-Dashboard/blob/master/Assets/Icons/PNG/KR%2064%20%20x%2064%20Purple.png" /><a href="https://github.com/Wagnerp/Krypton-NET-Version-Dashboard"> <img src="https://img.shields.io/badge/GitHub-Krypton%20Releases-blueviolet.svg" alt="Krypton Releases" /></a>

=======

## 2019-05-11 Build 973 - Updates
* Fixed issue [#147](https://github.com/Wagnerp/Krypton-NET-5.470/issues/147), hint does not have a designer reset option
* Fixed issue [#146](https://github.com/Wagnerp/Krypton-NET-5.470/issues/146), PInvoke types should be structures and not classes
* Fixed issue [#155](https://github.com/Wagnerp/Krypton-NET-5.470/issues/155), new Shadow feature does not handle "Window bar flashing" as expected 
* Fixed issue [#156](https://github.com/Wagnerp/Krypton-NET-5.470/issues/156), new Shadow feature crashes for some variables entered
* Fixed issue [#161](https://github.com/Wagnerp/Krypton-NET-5.470/issues/161), "Admin" does not show up in forms or MessageBox's
* Fixed issues [#68](https://github.com/Wagnerp/Krypton-NET-5.470/issues/68), The look of krypton themes does not appear in windows 10 when I use the ribbon control & [#162](https://github.com/Wagnerp/Krypton-NET-5.470/issues/162), Adding a ribbon control to a blank form causes the form title bar to always be blue (system accent) when selected
* New feature - now you can specify drop shadows on `KryptonForm` [#121](https://github.com/Wagnerp/Krypton-NET-5.470/issues/121). By design (or by accident :)), changing the shadow or form size values will display a offset of the shadow outcome.
* Patch for [#142](https://github.com/Wagnerp/Krypton-NET-5.470/issues/142) ribbon tab text not working, courtesy of Tape-Worm
* Fixed issue [#127](https://github.com/Wagnerp/Krypton-NET-5.470/issues/127), flashing tooltips
* Fixed issue [#130](https://github.com/Wagnerp/Krypton-NET-5.470/issues/130)
* Completed issue [#137](https://github.com/Wagnerp/Krypton-NET-5.470/issues/137)
* Fixed issue [#132](https://github.com/Wagnerp/Krypton-NET-5.470/issues/132), missing `OnDropDownClosed()` event for `KryptonComboBox`
* Fixed issue [#129](https://github.com/Wagnerp/Krypton-NET-5.470/issues/129), hints appeared grey even though they were enabled
* Fixed issue [#124](https://github.com/Wagnerp/Krypton-NET-5.470/issues/124), tooltips would occasionally throw an exception
* Removed files relating to 2018 [#130](https://github.com/Wagnerp/Krypton-NET-5.470/issues/130)
* Minor alterations to `ThemeManager.cs`
* New installer [#133](https://github.com/Wagnerp/Krypton-NET-5.470/issues/133)
* Fixed issue [#104](https://github.com/Wagnerp/Krypton-NET-5.470/issues/104), designer usage exceptions
* Fixed issue [#116](https://github.com/Wagnerp/Krypton-NET-5.470/issues/116)
* `KryptonManager` now displays themes and names correctly
* General fixes to `ThemeManager.cs` & `RibbonThemeManager.cs`
* Implement `DrawItem()` event in KryptonComboBox
* Merge Muratoner: Make input box have a PasswordChar
* Merge Alexandr250: Adding a textual cue (Watermark) to KryptonTextBox
* Merge Thavarajan: Datagridview combobox updated for datasource integration
* More [#17](https://github.com/Wagnerp/Krypton-NET-5.470/issues/17) 
* Make the PopupPosition values follow serialisation reflection IDE Designer needs
* Update example program for AllowDecimals
* Introduced an IconSpec definition for all KryptonDataGridViewColumn types so that icons can be drawn in KryptonDataGridView column header cells
* Adding a Multiline String Editor much like in VS' property grid to the KryptonTextBox control.
* Add Multiline String Editor in KryptonDataGridViewTextBox cells for multiline text editing
* Make MultilineStringEditor resizable.
* Adding KryptonDataGridViewCustomColumn type for DataGridViews
* Adding new KryptonDataGridViewBinaryColumn type for displaying and viewing binary data in GridViews.
* Make Hex-Mode default mode and add a button for exporting the data to a file.
* Slide panels instantly like Visual Studio
* Ignore DBNull.Value as well in GetFormattedValue
* Make the checkbox look a little nicer
* contextMenuStrip gradient color
* Adding a PaletteBackStyle.PanelCustom2 and PaletteBackStyle.PanelCustom3 for more theming flexibility
	* Continue to add custom numbers for the others custom# styles as well !
* Adding HoveredSelectionChanged event to KryptonComboBox
* Make KryptonDataGridViewComboBox accept objects rather than strings only
* Prop up KryptonComboBox with optional tooltips for items
* Extend support for DataGridView icons to Text & data cells
* Fixes to `KryptonDockingManager`, issue [#98](https://github.com/Wagnerp/Krypton-NET-5.470/issues/98)
* Add `*.xml` files to NuGet package, as per [#97](https://github.com/Wagnerp/Krypton-NET-5.470/issues/97)
* Fix for [#39](https://github.com/Wagnerp/Krypton-NET-5.470/issues/39)
* Fix for [#74](https://github.com/Wagnerp/Krypton-NET-5.470/issues/74)
* Fix for [#93](https://github.com/Wagnerp/Krypton-NET-5.470/issues/93)
* Fix for [#97](https://github.com/Wagnerp/Krypton-NET-5.470/issues/97)
* Now you are required to accept the license agreement when downloading new NuGet package versions
* You can now use `Krypton Tooltips` on listboxes and treeviews [#90](https://github.com/Wagnerp/Krypton-NET-5.470/issues/90)
* `ThemeManager.cs` is now available for ribbon controls
* You can now use `Krypton Tooltips` on every Krypton control [#85](https://github.com/Wagnerp/Krypton-NET-5.470/issues/85)
* `ThemeManager.cs` now makes it easier for developers to access the true theme names, without relying on nonsensical enumerations.
* Fix for [#56](https://github.com/Wagnerp/Krypton-NET-5.470/issues/56) courtesy of [richterAI](https://github.com/richterAl)
* Bugfix for [#75](https://github.com/Wagnerp/Krypton-NET-5.470/issues/75) courtesy of [nickfinch71](https://github.com/nickfinch71)
* For more information about this issue on NT 6.0 systems, please read thread [#75](https://github.com/Wagnerp/Krypton-NET-5.470/issues/75)
* Build 973 (build date Saturday 11th May, 2019) is now available on NuGet

=======

## 2018-09-28 Version **`4`** now becomes version **`5`**
* Major version number changed from `4` to `5` after experimenting successfuly with NuGet packages
	- Known bug if installing via NuGet, ToolBox images will not be displayed properly
* A new NuGet package can be obtained [here](https://www.nuget.org/packages/KryptonToolkitSuite5470/5.460.700) or by typing `KryptonToolkitSuite5460` in the package manager
* Build 700 (build date Friday 28th September, 2018) is now available through the **releases** tab
* Repository name change to reflect version changes
* All updates since February 2018 are now included

=======

## 2018-02-02 Initial commit
* Added generic C# `.gitignore` file
* Retarget to .NET 4.6 framework
* Version correction
* Nuget package released! Build 547 (build date February 9th, 2018) obtainable from [here](https://www.nuget.org/packages/KryptonToolkitSuite46/)
