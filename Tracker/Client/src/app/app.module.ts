import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routing';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { TasksComponent } from './components/tasks/tasks.component';
import { TaskService } from './services/taskService';
import { LoginComponent } from './components/login/login.component';
import { AuthService } from './services/auth.service';



@NgModule({
  declarations: [
    AppComponent,
    TasksComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
    FormsModule
  ],
  providers: [
    TaskService,
    AuthService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
