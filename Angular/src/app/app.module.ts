import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { DxDataGridModule } from 'devextreme-angular/ui/data-grid';
import { DxTextAreaModule } from 'devextreme-angular/ui/text-area';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, DxDataGridModule,  DxTextAreaModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
