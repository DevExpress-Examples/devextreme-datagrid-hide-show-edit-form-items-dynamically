import { useCallback, useRef } from 'react';
import DataGrid, {
  Column,
  Lookup,
  Form,
  Popup,
  Paging,
  Editing,
} from 'devextreme-react/data-grid';
import { SimpleItem, GroupItem, Label } from 'devextreme-react/form';
import config from 'devextreme/core/config';

import type { DataGridRef, DataGridTypes } from 'devextreme-react/data-grid';
import type { FormTypes } from 'devextreme-react/form';
import type { TextAreaTypes } from 'devextreme-react/text-area';
import service, { type Employee, type State } from './data';

import './App.css';
import 'devextreme/dist/css/dx.material.blue.light.compact.css';
import 'devextreme-react/text-area';

config({
  editorStylingMode: 'filled',
});

const notesEditorOptions: TextAreaTypes.Properties = { height: 100 };
const dataSource: Employee[] = service.getEmployees();
const states: State[] = service.getStates();

function isHomeAddressGroup(item: FormTypes.GroupItem): boolean {
  return Boolean(item?.itemType === 'group' && item?.caption === 'Home Address');
}

function setCellValue(
  this: DataGridTypes.Column,
  newData: Employee,
  value: number,
  currentRowData: Employee,
): void {
  // eslint-disable-next-line @typescript-eslint/no-floating-promises
  this.defaultSetCellValue?.(newData, value, currentRowData);
}

function onEditorPreparing(e: DataGridTypes.EditorPreparingEvent<Employee, number>): void {
  if (e.dataField === 'LastName' && e.parentType === 'dataRow') {
    e.editorOptions.disabled = Boolean(e.row?.data?.FirstName === '');
  }
}

function onInitNewRow(e: DataGridTypes.InitNewRowEvent<Employee, number>): void {
  e.data.AddressRequired = false;
  e.data.FirstName = '';
}

function App(): JSX.Element {
  const dataGrid = useRef<DataGridRef<Employee, number>>(null);

  const customizeItem = useCallback((item: FormTypes.Item): void => {
    if (isHomeAddressGroup(item)) {
      const dataGridInstance = dataGrid.current?.instance();
      if (!dataGridInstance) return;

      const editing = dataGridInstance.option('editing');
      if (editing?.editRowKey != null) {
        const rowIndex = dataGridInstance.getRowIndexByKey(editing.editRowKey);
        item.visible = dataGridInstance.cellValue(rowIndex, 'AddressRequired');
      }
    }
  }, []);

  return (
    <div className="main">
      <DataGrid<Employee, number>
        ref={dataGrid}
        onEditorPreparing={onEditorPreparing}
        onInitNewRow={onInitNewRow}
        dataSource={dataSource}
        keyExpr="ID"
        showBorders={true}>
        <Paging enabled={false} />
        <Editing
          mode="popup"
          allowAdding={true}
          allowUpdating={true}>
          <Popup
            title="Employee Info"
            showTitle={true}
            width={700}
            height={725}>
          </Popup>
          <Form customizeItem={customizeItem}>
            <GroupItem
              colCount={2}
              colSpan={2}>
              <SimpleItem dataField="FirstName" />
              <SimpleItem dataField="LastName" />
              <SimpleItem dataField="Prefix" />
              <SimpleItem dataField="BirthDate" />
              <SimpleItem dataField="Position" />
              <SimpleItem dataField="HireDate" />
              <SimpleItem
                dataField="Notes"
                editorType="dxTextArea"
                colSpan={2}
                editorOptions={notesEditorOptions} />
            </GroupItem>
            <SimpleItem
              dataField="AddressRequired"
              colSpan={2}
            >
              <Label location="left" />
            </SimpleItem>
            <GroupItem
              caption="Home Address"
              colCount={2}
              colSpan={2}>
              <SimpleItem dataField="StateID" />
              <SimpleItem dataField="Address" />
            </GroupItem>
          </Form>
        </Editing>
        <Column
          dataField="Prefix"
          caption="Title"
          width={70} />
        <Column
          dataField="FirstName"
          setCellValue={setCellValue} />
        <Column dataField="LastName" />
        <Column
          dataField="BirthDate"
          dataType="date" />
        <Column
          dataField="Position"
          width={170} />
        <Column
          dataField="HireDate"
          dataType="date" />
        <Column
          dataField="StateID"
          caption="State"
          width={125}>
          <Lookup
            dataSource={states}
            displayExpr="Name"
            valueExpr="ID">
          </Lookup>
        </Column>
        <Column
          dataField="Address"
          visible={false} />
        <Column
          dataField="Notes"
          visible={false} />
        <Column
          dataField="AddressRequired"
          setCellValue={setCellValue}
          visible={false} />
      </DataGrid>
    </div>
  );
}

export default App;
