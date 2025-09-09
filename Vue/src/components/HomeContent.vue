<script setup lang="ts">
import { ref } from 'vue';
import {
  DxDataGrid,
  DxColumn,
  DxPaging,
  DxEditing,
  DxPopup,
  DxLookup,
  DxLabel,
  DxForm,
  type DxDataGridTypes
} from 'devextreme-vue/data-grid';
import { DxItem, type DxFormTypes } from 'devextreme-vue/form';
import { type DxTextAreaTypes } from 'devextreme-vue/text-area';
import config from 'devextreme/core/config';
import service, { type Employee } from '../data';
import 'devextreme-vue/text-area';
import 'devextreme/dist/css/dx.material.blue.light.compact.css';

config({
  editorStylingMode: 'filled',
});

const dataSource = service.getEmployees();
const states = service.getStates();

function isHomeAddressGroup(item: DxFormTypes.GroupItem): boolean {
  return Boolean(item?.itemType === 'group' && item?.caption === 'Home Address');
}

const notesEditorProperties: DxTextAreaTypes.Properties = { height: 100 };
const dataGridRef = ref<DxDataGrid | null>(null);

function customizeItem(item: DxFormTypes.Item): void {
  if (isHomeAddressGroup(item)) {
    const gridInstance = dataGridRef.value?.instance;
    if (!gridInstance) return;

    const editing = gridInstance.option('editing');
    if (!editing?.editRowKey) return;

    const rowIndex = gridInstance.getRowIndexByKey(editing.editRowKey);
    item.visible = gridInstance.cellValue(rowIndex, 'AddressRequired');
  }
}

function onEditorPreparing(e: DxDataGridTypes.EditorPreparingEvent<Employee, number>): void {
  if (e.dataField === 'LastName' && e.parentType === 'dataRow') {
    e.editorOptions.disabled = Boolean(e.row?.data?.FirstName === '');
  }
}

function onInitNewRow(e: DxDataGridTypes.InitNewRowEvent<Employee, number>): void {
  e.data.AddressRequired = false;
  e.data.FirstName = '';
}

function setCellValue(
  this: DxDataGridTypes.Column,
  newData: Employee,
  value: number,
  currentRowData: Employee
): void {
  this.defaultSetCellValue?.(newData, value, currentRowData);
}
</script>

<template>
  <div>
    <DxDataGrid
      :data-source="dataSource"
      ref="dataGridRef"
      :show-borders="true"
      @editor-preparing="onEditorPreparing"
      @init-new-row="onInitNewRow"
      key-expr="ID"
    >
      <DxPaging :enabled="false"/>
      <DxEditing
        :allow-updating="true"
        :allow-adding="true"
        mode="popup"
      >
        <DxPopup
          :show-title="true"
          :width="700"
          :height="725"
          title="Employee Info"
        />
        <DxForm :customize-item="customizeItem">
          <DxItem
            :col-count="2"
            :col-span="2"
            item-type="group"
          >
            <DxItem data-field="FirstName"/>
            <DxItem data-field="LastName"/>
            <DxItem data-field="Prefix"/>
            <DxItem data-field="BirthDate"/>
            <DxItem data-field="Position"/>
            <DxItem data-field="HireDate"/>
            <DxItem
              :col-span="2"
              :editor-options="notesEditorProperties"
              data-field="Notes"
              editor-type="dxTextArea"
            />
          </DxItem>
          <DxItem
            data-field="AddressRequired"
            :col-span="2"
          >
            <DxLabel location="left"/>
          </DxItem>
          <DxItem
            :col-count="2"
            :col-span="2"
            item-type="group"
            caption="Home Address"
          >
            <DxItem data-field="StateID"/>
            <DxItem data-field="Address"/>
          </DxItem>
        </DxForm>
      </DxEditing>
      <DxColumn
        :width="70"
        data-field="Prefix"
        caption="Title"
      />
      <DxColumn
        :set-cell-value="setCellValue"
        data-field="FirstName"
      />
      <DxColumn data-field="LastName"/>
      <DxColumn
        data-field="BirthDate"
        data-type="date"
      />
      <DxColumn
        :width="170"
        data-field="Position"
      />
      <DxColumn
        data-field="HireDate"
        data-type="date"
      />
      <DxColumn
        :width="125"
        data-field="StateID"
        caption="State"
      >
        <DxLookup
          :data-source="states"
          value-expr="ID"
          display-expr="Name"
        />
      </DxColumn>
      <DxColumn
        :visible="false"
        :set-cell-value="setCellValue"
        data-field="AddressRequired"
      />
      <DxColumn
        :visible="false"
        data-field="Address"
      />
      <DxColumn
        :visible="false"
        data-field="Notes"
      />
    </DxDataGrid>
  </div>
</template>
