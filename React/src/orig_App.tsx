import { useCallback, useRef } from 'react';
import './App.css';
import 'devextreme/dist/css/dx.material.blue.light.compact.css';
import config from 'devextreme/core/config';
import 'devextreme-react/text-area';
import service, { Employee, State } from './data';
import DataGrid, {
  Column,
  Lookup,
  Form,
  Popup,
  Paging,
  Editing
} from 'devextreme-react/data-grid';
import { SimpleItem, GroupItem } from 'devextreme-react/form';

import {
  Column as EditingColumn,
  EditorPreparingEvent,
  InitNewRowEvent,
} from 'devextreme/ui/data_grid';

import { Item as FormItem, GroupItem as FormGroupItem } from 'devextreme/ui/form';
import { Properties as TextAreaProperties } from 'devextreme/ui/text_area';

config({
  editorStylingMode: 'filled'
});

const notesEditorOptions: TextAreaProperties = { height: 100 };
const dataSource: Employee[] = service.getEmployees();
const states: State[] = service.getStates();

function isHomeAddressGroup(item: FormGroupItem): boolean {
  return item && item.itemType === 'group' && item.caption === 'Home Address';
}
function setCellValue(
  this: EditingColumn,
  newData: Employee,
  value: number,
  currentRowData: Employee
) {
  this.defaultSetCellValue!(newData, value, currentRowData);
}
function onEditorPreparing(e: EditorPreparingEvent<Employee, number>) {
  if (e.dataField === 'LastName' && e.parentType === 'dataRow') {
    e.editorOptions.disabled = e.row?.data && e.row?.data.FirstName === '';
  }
}
function onInitNewRow(e: InitNewRowEvent<Employee, number>) {
  e.data.AddressRequired = false;
  e.data.FirstName = '';
}

function App() {

  const dataGrid = useRef<DataGrid<Employee, number>>(null);

  const customizeItem = useCallback((item: FormItem) => {
    if (isHomeAddressGroup(item)) {
      const dataGridInstance = dataGrid.current!.instance
      const editing = dataGridInstance.option('editing');
      const rowIndex = dataGridInstance.getRowIndexByKey(editing?.editRowKey!);
      item.visible = dataGridInstance.cellValue(rowIndex, 'AddressRequired');
    }
  }, []);

  return (
    <div className="main">
      <DataGrid<Employee, number>
        ref={dataGrid}
        onEditorPreparing={onEditorPreparing}
        onInitNewRow={onInitNewRow}
        dataSource={dataSource}
        keyExpr={"ID"}
        showBorders={true}>
        <Paging enabled={false} />
        <Editing
          mode={"popup"}
          allowAdding={true}
          allowUpdating={true}>
          <Popup
            title={"Employee Info"}
            showTitle={true}
            width={700}
            height={725}>
          </Popup>
          <Form customizeItem={customizeItem}>
            <GroupItem
              colCount={2}
              colSpan={2}>
              <SimpleItem dataField={"FirstName"} />
              <SimpleItem dataField={"LastName"} />
              <SimpleItem dataField={"Prefix"} />
              <SimpleItem dataField={"BirthDate"} />
              <SimpleItem dataField={"Position"} />
              <SimpleItem dataField={"HireDate"} />
              <SimpleItem
                dataField="Notes"
                editorType={"dxTextArea"}
                colSpan={2}
                editorOptions={notesEditorOptions} />
            </GroupItem>
            <SimpleItem
              dataField={"AddressRequired"}
              colSpan={2} />
            <GroupItem
              caption={"Home Address"}
              colCount={2}
              colSpan={2}>
              <SimpleItem dataField={"StateID"} />
              <SimpleItem dataField={"Address"} />
            </GroupItem>
          </Form>
        </Editing>
        <Column
          dataField={"Prefix"}
          caption={"Title"}
          width={70} />
        <Column
          dataField={"FirstName"}
          setCellValue={setCellValue} />
        <Column dataField={"LastName"} />
        <Column
          dataField={"BirthDate"}
          dataType={"date"} />
        <Column
          dataField={"Position"}
          width={170} />
        <Column
          dataField={"HireDate"}
          dataType={"date"} />
        <Column
          dataField={"StateID"}
          caption={"State"}
          width={125}>
          <Lookup
            dataSource={states}
            displayExpr={"Name"}
            valueExpr={"ID"}>
          </Lookup>
        </Column>
        <Column
          dataField={"Address"}
          visible={false} />
        <Column
          dataField={"Notes"}
          visible={false} />
        <Column
          dataField={"AddressRequired"}
          setCellValue={setCellValue}
          visible={false} />
      </DataGrid>
    </div>
  );
}

export default App;
