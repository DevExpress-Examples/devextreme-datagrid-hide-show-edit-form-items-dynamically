import { bootstrapApplication } from '@angular/platform-browser';
import { provideZoneChangeDetection } from '@angular/core';
import config from 'devextreme/core/config';
import { AppComponent } from './app/app.component';
import { licenseKey } from './devextreme-license';

config({ licenseKey });

bootstrapApplication(AppComponent, {
  providers: [provideZoneChangeDetection()],
}).catch((err) => console.error(err));
