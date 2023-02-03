import { bootstrapApplication } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { StudentStandAloneComponent } from './app/student-stand-alone/student-stand-alone.component';


// platformBrowserDynamic().bootstrapModule(AppModule)
//   .catch(err => console.error(err));


bootstrapApplication(StudentStandAloneComponent)