<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/190147423/20.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828685)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DataGrid - How to hide/disable Edit Form items based on another item's value

This example demonstrates how to show/hide or enable/disable form items based on another item's value in DataGrid.

The main steps are:
- Define the [setCellValue](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/columns/#setCellValue)  callback function for required columns to force re-rendering items after an editor value is changed.
- Use [getRowIndexByKey](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Methods/#getRowIndexByKeykey) and [cellValue](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Methods/#cellValuerowIndex_dataField) to obtain current editor values.
- Change an item's [visible](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxForm/Item_Types/SimpleItem/#visible) option in the [customizeItem](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxForm/Configuration/#customizeItem) form's event handler. 
- Define [onEditorPreparing](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/#onEditorPreparing) to change the [disabled](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTextBox/Configuration/#disabled) option of the required form item editor.


In our particular case, we 
- hide the **Home Address** form item if the **AddressRequired** value is false.
- disable the **LastName** item editor if the **FirstName** form item value is empty. 
