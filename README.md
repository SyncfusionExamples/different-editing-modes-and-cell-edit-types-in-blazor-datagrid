# Different Editing Modes and Cell Edit Types in Blazor DataGrid

## Overview

This sample demonstrates how to configure editing in the Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) using a combination of grid edit settings, toolbar commands, and column-specific editor configurations. The implementation uses the Syncfusion SfGrid component with editing enabled through EditMode.Normal and showcases how different columns can use different editor types. The sample also demonstrates custom DatePicker editor settings, dropdown-based editing, primary key configuration, and read-only column behavior. It is useful for developers who want to understand how to customize editing experiences within the Blazor DataGrid while maintaining a consistent user experience.

## Key Features

- Uses the Syncfusion `SfGrid` component to display and edit order records.
- Enables editing operations through toolbar commands: `Add`, `Edit`, `Delete`, `Update`, and `Cancel`.
- Configures editing behavior using `Mode="EditMode.Normal"`.
- Enables record modification with `AllowEditing="true"`.
- Enables row deletion with `AllowDeleting="true"`.
- Identifies the primary key column using `IsPrimaryKey="true"`.
- Restricts editing for specific fields using `AllowEditing="false"`.
- Configures a custom date editor through `DateEditCellParams`.
- Uses `DatePickerModel` with `ShowClearButton = false`.
- Applies editor settings through `EditorSettings="@DateEditParams"`.
- Enables dropdown editing with `EditType="EditType.DropDownEdit"`.
- Loads sample data using `OrdersDetails.GetOrdersDetails()`.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open the solution file `DifferentEditingSample.sln`.
3. Restore all NuGet packages.
4. Set the `Server` project as the startup project if required.
5. Build the solution.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the Server project directory.

```bash
cd Server
dotnet restore
dotnet run
```

4. Open the local URL displayed in the terminal after the application starts.

## Project Structure

- `Client/Pages/Index.razor` — contains the `SfGrid` implementation, edit settings, toolbar configuration, column definitions, custom editor settings, DatePicker editor configuration, and DropDown editor configuration.
- `Client/OrdersDetails.cs` — contains the `OrdersDetails` model and sample data generation used by the DataGrid.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For feature documentation, see the Syncfusion Blazor DataGrid Editing documentation: https://help.syncfusion.com/grid-sdk/blazor/data-grid/edit-types

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the Syncfusion license terms at https://www.syncfusion.com/sales/pricing?category=ui-components before using Syncfusion components in your own applications.
