<script setup lang="ts">
import { ref } from "vue";

import "devextreme/dist/css/dx.material.blue.light.compact.css";
import {
  DxDataGrid,
  DxColumn,
  DxPaging,
  DxEditing,
  DxPopup,
  DxLookup,
  DxForm
} from "devextreme-vue/data-grid";
import { DxItem } from "devextreme-vue/form";
import "devextreme-vue/text-area";


import config from 'devextreme/core/config';
import service from '../data';

import type dxDataGrid from 'devextreme/ui/data_grid';
import type {
  Column,
  EditorPreparingEvent,
  InitNewRowEvent,
} from 'devextreme/ui/data_grid';
import type { Item, GroupItem } from 'devextreme/ui/form';
import type { Properties as TextAreaProperties } from 'devextreme/ui/text_area';
import type { Employee } from '../data';

config({
  editorStylingMode: 'filled',
});

const dataSource = service.getEmployees();
const states = service.getStates();
function isHomeAddressGroup(item: GroupItem): boolean {
  return item && item.itemType === 'group' && item.caption === 'Home Address';
}
const notesEditorProperties: TextAreaProperties = { height: 100 };
const dataGridRef = ref<DxDataGrid>();

function customizeItem(item: Item){
  if (isHomeAddressGroup(item)) {
    const gridInstance = dataGridRef.value?.instance! as dxDataGrid<Employee, number>;
    const editing = gridInstance.option('editing');
    const rowIndex = gridInstance.getRowIndexByKey(editing?.editRowKey!);
    item.visible = gridInstance.cellValue(rowIndex, 'AddressRequired');
  }
};
function onEditorPreparing(e: EditorPreparingEvent<Employee, number>) {
  if (e.dataField === 'LastName' && e.parentType === 'dataRow') {
    e.editorOptions.disabled = e.row?.data?.FirstName === '';
  }
}
function onInitNewRow(e: InitNewRowEvent<Employee, number>) {
  e.data.AddressRequired = false;
  e.data.FirstName = '';
}
function setCellValue(
  this: Column,
  newData: Employee,
  value: number,
  currentRowData: Employee
) {
  this.defaultSetCellValue!(newData, value, currentRowData);
}
</script>
<template>
  <div>
    <DxDataGrid :data-source="dataSource" ref="dataGridRef" :show-borders="true" @editor-preparing="onEditorPreparing"
      @init-new-row="onInitNewRow" key-expr="ID">
      <DxPaging :enabled="false" />
      <DxEditing :allow-updating="true" :allow-adding="true" mode="popup">
        <DxPopup :show-title="true" :width="700" :height="725" title="Employee Info">
        </DxPopup>
        <DxForm :customize-item="customizeItem">
          <DxItem :col-count="2" :col-span="2" item-type="group">
            <DxItem data-field="FirstName" />
            <DxItem data-field="LastName" />
            <DxItem data-field="Prefix" />
            <DxItem data-field="BirthDate" />
            <DxItem data-field="Position" />
            <DxItem data-field="HireDate" />
            <DxItem :col-span="2" :editor-options="notesEditorProperties" data-field="Notes" editor-type="dxTextArea" />
          </DxItem>
          <DxItem data-field="AddressRequired" :col-span="2" />
          <DxItem :col-count="2" :col-span="2" item-type="group" caption="Home Address">
            <DxItem data-field="StateID" />
            <DxItem data-field="Address" />
          </DxItem>
        </DxForm>
      </DxEditing>
      <DxColumn :width="70" data-field="Prefix" caption="Title" />
      <DxColumn :set-cell-value="setCellValue" data-field="FirstName" />
      <DxColumn data-field="LastName" />
      <DxColumn data-field="BirthDate" data-type="date" />
      <DxColumn :width="170" data-field="Position" />
      <DxColumn data-field="HireDate" data-type="date" />
      <DxColumn :width="125" data-field="StateID" caption="State">
        <DxLookup :data-source="states" value-expr="ID" display-expr="Name" />
      </DxColumn>
      <DxColumn :visible="false" :set-cell-value="setCellValue" data-field="AddressRequired" />
      <DxColumn :visible="false" data-field="Address" />
      <DxColumn :visible="false" data-field="Notes" />
    </DxDataGrid>
  </div>
</template>
