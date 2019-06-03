import { Component, ViewChild } from '@angular/core';
import { DataService } from './data.service';
import config from 'devextreme/core/config';
import { DxDataGridComponent } from 'devextreme-angular';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [DataService],
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  dataSource: any;
  states: any;
  rowKey: any;
  @ViewChild(DxDataGridComponent) dataGrid: DxDataGridComponent;
  constructor(service: DataService) {
    config({
      editorStylingMode: 'filled'
    });
    this.dataSource = service.getEmployees();
    this.states = service.getStates();
  }
  customizeItem = (item) => {

    if (item && item.itemType === "group" && item.caption === "Home Address") {
      let index = this.dataGrid.instance.getRowIndexByKey(this.rowKey) || 0;
      let isVisible = this.dataGrid.instance.cellValue(index, "AddressRequired");
      item.visible = isVisible;
    }
  }
  onEditorPreparing(e) {
    if (e.dataField === "LastName" && e.parentType === "dataRow") {
      e.editorOptions.disabled = e.row.data && e.row.data.FirstName === "";
    }
  }
  onEditingStart(e) {
    this.rowKey = e.key;
  }
  onInitNewRow(e) {
    e.data.AddressRequired = false;
    e.data.FirstName = "";
  }
  setCellValue(newData, value) {
    let column = (<any>this);
    column.defaultSetCellValue(newData, value)
  }
}
