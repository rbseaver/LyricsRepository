import { IVersionService } from './IVersionService';
import { VersionApiService } from './../api/version-api.service';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VersionService implements IVersionService {

  constructor(private versionApiService: VersionApiService) { }

  getVersion(): Observable<string> {
    return this.versionApiService.get();
  }
}
