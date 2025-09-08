import { Component, ViewChild } from '@angular/core';
import { DxDataGridComponent, type DxDataGridTypes } from 'devextreme-angular/ui/data-grid';
import config from 'devextreme/core/config';

import type { DxFormTypes } from 'devextreme-angular/ui/form';
import type { DxTextAreaTypes } from 'devextreme-angular/ui/text-area';
import { DataService, type Employee, type State } from './data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [DataService],
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  @ViewChild(DxDataGridComponent) dataGrid!: DxDataGridComponent<Employee, number>;

  dataSource: Employee[];

  states: State[];

  notesEditorProperties: DxTextAreaTypes.Properties;

  constructor(service: DataService) {
    config({
      editorStylingMode: 'filled',
    });
    this.dataSource = service.getEmployees();
    this.states = service.getStates();
    this.notesEditorProperties = { height: 100 };
  }

  isHomeAddressGroup(item: DxFormTypes.GroupItem): boolean {
    return Boolean(item?.itemType === 'group' && item?.caption === 'Home Address');
  }

  customizeItem = (item: DxFormTypes.Item): void => {
    if (this.isHomeAddressGroup(item)) {
      const gridInstance = this.dataGrid.instance;
      if (!gridInstance) return;

      const editing = gridInstance.option('editing');
      if (!editing?.editRowKey) return;

      const rowIndex = gridInstance.getRowIndexByKey(editing.editRowKey);
      item.visible = gridInstance.cellValue(rowIndex, 'AddressRequired');
    }
  };

  onEditorPreparing(e: DxDataGridTypes.EditorPreparingEvent<Employee, number>): void {
    if (e.dataField === 'LastName' && e.parentType === 'dataRow') {
      e.editorOptions.disabled = Boolean(e.row?.data?.FirstName === '');
    }
  }

  onInitNewRow(e: DxDataGridTypes.InitNewRowEvent<Employee, number>): void {
    e.data.AddressRequired = false;
    e.data.FirstName = '';
  }

  setCellValue(
    this: DxDataGridTypes.Column,
    newData: Employee,
    value: number,
    currentRowData: Employee,
  ): void {
    // eslint-disable-next-line @typescript-eslint/no-floating-promises
    this.defaultSetCellValue?.(newData, value, currentRowData);
  }
}
