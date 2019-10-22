import { Component, OnInit } from '@angular/core';
import { LeftSideBarComponent } from '../left-side-bar/left-side-bar.component';
import { RightSideBarComponent } from '../right-side-bar/right-side-bar.component';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
