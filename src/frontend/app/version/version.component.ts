import { VersionService } from './version.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { take } from 'rxjs/operators';


@Component({
  selector: 'app-version',
  templateUrl: './version.component.html',
  styleUrls: ['./version.component.scss']
})
export class VersionComponent implements OnInit {
  public DefaultVersion = '1.0.0.0';
  public version: Observable<string>;

  constructor(private versionService: VersionService) {
  }

  ngOnInit(): void {
    this.version = this.versionService
      .getVersion()
      .pipe(take(1));
  }
}
