import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { TaskModel } from '../app/models/TaskModel';


@Injectable()
export class TaskService {
    constructor(private http: HttpClient){}

    getAllTasks() {
        return this.http.get<TaskModel[]>('/api/tasks/GetTasks').toPromise();
    }

    saveTask(task: TaskModel) {
        return this.http.post<TaskModel>('/api/tasks/AddTask', task).toPromise();
    }
}