import config from 'devextreme/core/config';
import { licenseKey } from './devextreme-license';

config({ licenseKey });

import { bootstrapApplication } from '@angular/platform-browser';
import { provideZoneChangeDetection } from '@angular/core';
import { AppComponent } from './app/app.component';

bootstrapApplication(AppComponent, {
  providers: [provideZoneChangeDetection()],
}).catch((err) => console.error(err));
