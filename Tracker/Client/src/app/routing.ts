import {Routes, Route} from '@angular/router';
import {TasksComponent} from './components/tasks/tasks.component';
import {LoginComponent} from './components/login/login.component';

export const appRoutes: Routes = [
    {path: 'tasks', component: TasksComponent},
    { path: 'login', component: LoginComponent },
    {
        path: '',
        redirectTo: 'login',
        pathMatch: 'full'
    },
    { path: '**', component: LoginComponent }

]