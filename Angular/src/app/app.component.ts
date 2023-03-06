import { Component, ViewChild } from '@angular/core';
import { DxDataGridComponent } from 'devextreme-angular';
import { DataService, Employee, State } from './data.service';

import config from 'devextreme/core/config';

import dxDataGrid, {
  Column,
  EditorPreparingEvent,
  InitNewRowEvent,
} from 'devextreme/ui/data_grid';
import { Item, GroupItem } from 'devextreme/ui/form';
import { Properties as TextAreaProperties } from 'devextreme/ui/text_area';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [DataService],
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  @ViewChild(DxDataGridComponent) dataGrid!: DxDataGridComponent;

  dataSource: Employee[];
  states: State[];
  notesEditorProperties: TextAreaProperties;

  constructor(service: DataService) {
    config({
      editorStylingMode: 'filled',
    });
    this.dataSource = service.getEmployees();
    this.states = service.getStates();
    this.notesEditorProperties = { height: 100 };
  }
  isHomeAddressGroup(item: GroupItem): boolean {
    return item && item.itemType === 'group' && item.caption === 'Home Address';
  }
  customizeItem = (item: Item) => {
    if (this.isHomeAddressGroup(item)) {
      const gridInstance: dxDataGrid<Employee, number> = this.dataGrid.instance;
      const editing = gridInstance.option('editing');
      const rowIndex = gridInstance.getRowIndexByKey(editing?.editRowKey!);
      item.visible = gridInstance.cellValue(rowIndex, 'AddressRequired');
    }
  };
  onEditorPreparing(e: EditorPreparingEvent<Employee, number>) {
    if (e.dataField === 'LastName' && e.parentType === 'dataRow') {
      e.editorOptions.disabled = e.row?.data && e.row?.data.FirstName === '';
    }
  }
  onInitNewRow(e: InitNewRowEvent<Employee, number>) {
    e.data.AddressRequired = false;
    e.data.FirstName = '';
  }
  setCellValue(
    this: Column,
    newData: Employee,
    value: number,
    currentRowData: Employee
  ) {
    this.defaultSetCellValue!(newData, value, currentRowData);
  }
}
