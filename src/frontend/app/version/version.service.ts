import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class VersionService {

  constructor() { }

  getVersion(): string {
    return '1.0.0.0';
  }
}
