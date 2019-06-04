# Angular - DataGrid - How to hide/disable certain Edit Form items based on another item's value

This example demonstrates how to show/hide or enable/disable form items based on another item's value in DataGrid.

The main steps are:
- Define the [setCellValue](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/columns/#setCellValue)  callback function for required columns to force re-rendering items after an editor value is changed.
- Use [onEditingStart](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/#onEditingStart) to keep the current row key.
- Use [getRowIndexByKey](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Methods/#getRowIndexByKeykey) and [cellValue](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Methods/#cellValuerowIndex_dataField) to obtain current editor values.
- Change an item's [visible](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxForm/Item_Types/SimpleItem/#visible) option in the [customizeItem](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxForm/Configuration/#customizeItem) form's event handler. 
- Define [onEditorPreparing](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/#onEditorPreparing) to change the [disabled](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTextBox/Configuration/#disabled) option of the required form item editor.


In our particular case, we 
- hide the **Home Address** form item if the **AddressRequired** value is false.
- disable the **LastName** item editor if the **FirstName** form item value is empty. 

Take a look at the following files of this example to see the required code: 

- [app.component.html](https://github.com/DevExpress-Examples/DataGrid-How-to-hide-disable-certain-Edit-Form-items-based-on-another-item-s-value/blob/19.1.3%2B/src/app/app.component.html)
- [app.component.ts](https://github.com/DevExpress-Examples/DataGrid-How-to-hide-disable-certain-Edit-Form-items-based-on-another-item-s-value/blob/19.1.3%2B/src/app/app.component.ts)

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 7.3.0.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).

To get more help on DevExtreme submit an issue on [GitHub](https://github.com/DevExpress/devextreme/issues) or [Support Center](https://www.devexpress.com/Support/Center/Question/Create)
