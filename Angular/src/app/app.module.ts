import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DxDataGridModule } from 'devextreme-angular/ui/data-grid';
import { DxTextAreaModule } from 'devextreme-angular/ui/text-area';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    DxDataGridModule,
    DxTextAreaModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
