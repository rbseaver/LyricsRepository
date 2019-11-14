import { VersionService } from './version.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-version',
  templateUrl: './version.component.html',
  styleUrls: ['./version.component.scss']
})
export class VersionComponent implements OnInit {
  public version: string;

  constructor(private versionService: VersionService) { }

  ngOnInit() {
    this.versionService.getVersion().subscribe(x => this.version = x);
  }
}
