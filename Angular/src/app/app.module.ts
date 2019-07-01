import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { DxDataGridModule, DxTemplateModule, DxTextAreaModule } from 'devextreme-angular';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, DxDataGridModule, DxTemplateModule, DxTextAreaModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
