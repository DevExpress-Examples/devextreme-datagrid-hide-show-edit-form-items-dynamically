<template>
  <dx-data-grid
    :data-source="dataSource"
    :ref="gridRefName"
    :show-borders="true"
    @editor-preparing="onEditorPreparing"
    @init-new-row="onInitNewRow"
    @editing-start="onEditingStart"
    key-expr="ID"
  >
    <dx-paging :enabled="false" />
    <dx-editing :allow-updating="true" :allow-adding="true" mode="popup">
      <dx-popup :show-title="true" :width="700" :height="725" title="Employee Info">
        <dx-position my="top" at="top" of="window" />
      </dx-popup>
      <dx-form :customize-item="customizeItem">
        <dx-item :col-count="2" :col-span="2" item-type="group">
          <dx-item data-field="FirstName" />
          <dx-item data-field="LastName" />
          <dx-item data-field="Prefix" />
          <dx-item data-field="BirthDate" />
          <dx-item data-field="Position" />
          <dx-item data-field="HireDate" />
          <dx-item
            :col-span="2"
            :editor-options="editorOptions"
            data-field="Notes"
            editor-type="dxTextArea"
          />
        </dx-item>
        <dx-item data-field="AddressRequired" :col-span="2" />
        <dx-item :col-count="2" :col-span="2" item-type="group" caption="Home Address">
          <dx-item data-field="StateID" />
          <dx-item data-field="Address" />
        </dx-item>
      </dx-form>
    </dx-editing>
    <dx-column :width="70" data-field="Prefix" caption="Title" />
    <dx-column :set-cell-value="setCellValue" data-field="FirstName" />
    <dx-column data-field="LastName" />
    <dx-column data-field="BirthDate" data-type="date" />
    <dx-column :width="170" data-field="Position" />
    <dx-column data-field="HireDate" data-type="date" />
    <dx-column :width="125" data-field="StateID" caption="State">
      <dx-lookup :data-source="states" value-expr="ID" display-expr="Name" />
    </dx-column>
    <dx-column :visible="false" :set-cell-value="setCellValue" data-field="AddressRequired" />
    <dx-column :visible="false" data-field="Address" />
    <dx-column :visible="false" data-field="Notes" />
  </dx-data-grid>
</template>

<script>
import {
  DxDataGrid,
  DxColumn,
  DxPaging,
  DxEditing,
  DxPopup,
  DxLookup,
  DxPosition,
  DxForm
} from "devextreme-vue/data-grid";
import { DxItem } from "devextreme-vue/form";
import "devextreme-vue/text-area";

import service from "../data";

export default {
  name: "Home",
  components: {
    DxDataGrid,
    DxColumn,
    DxPaging,
    DxEditing,
    DxPopup,
    DxLookup,
    DxPosition,
    DxForm,
    DxItem
  },
  data() {
    return {
      states: service.getStates(),
      dataSource: service.getEmployees(),
      editorOptions: { height: 100 },
      gridRefName: "grid",
      rowKey: -1,
      setCellValue: function(newData, value) {
        let column = this;
        column.defaultSetCellValue(newData, value);
      }
    };
  },
  methods: {
    customizeItem(item) {
      if (
        item &&
        item.itemType === "group" &&
        item.caption === "Home Address"
      ) {        
        let index =  this.dataGrid.getRowIndexByKey(this.rowKey);
        index = index === -1 ? 0 : index ;
        let isVisible = this.dataGrid.cellValue(index, "AddressRequired");
        item.visible = isVisible;
      }
    },
    onEditorPreparing(e) {
      if (e.dataField === "LastName" && e.parentType === "dataRow") {
        e.editorOptions.disabled = e.row.data && e.row.data.FirstName === "";
      }
    },
    onEditingStart(e) {
      this.rowKey = e.key;
    },
    onInitNewRow(e) {
      this.rowKey = -1;
      e.data.AddressRequired = false;
      e.data.FirstName = "";
    }
  },
  computed: {
    dataGrid: function() {
      return this.$refs[this.gridRefName].instance;
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
