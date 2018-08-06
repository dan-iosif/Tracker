import { Component, OnInit } from '@angular/core';
import { TaskModel } from '../../models/TaskModel';
import { TaskService } from '../../services/taskService';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.css']
})
export class TasksComponent implements OnInit {
  tasks: Array<TaskModel>;
  task: TaskModel;
  errorMessage: string;

  constructor(private taskService: TaskService) { }

  ngOnInit() {
    this.getTasks();
    this.task = new TaskModel();
  }
  
  getTasks() {
    this.taskService.getAllTasks().then(
        tasks => this.tasks = tasks,
        error => this.errorMessage = <any>error
    );
  }

  addTask() {
    console.log(this.task);
    this.taskService.saveTask(this.task).then(
      success => {
        this.errorMessage = 'Task ' + this.task.Name + ' added';
      },
      error => {
        this.errorMessage = 'There was a problem';
      }
    );
  }

}


