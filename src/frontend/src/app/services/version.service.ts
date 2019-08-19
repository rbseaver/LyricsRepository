import { Injectable } from '@angular/core';
import { IVersionProvider } from '../providers/IVersionProvider';

@Injectable({
  providedIn: 'root'
})
export class VersionService {

  constructor(private versionProvider: IVersionProvider) { }
}
