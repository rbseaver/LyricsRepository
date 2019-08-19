import { Injectable } from '@angular/core';
import { IVersionProvider } from './IVersionProvider';

@Injectable({
  providedIn: 'root'
})
export class PackageVersionProviderService implements IVersionProvider {
  getVersion(): string {
    throw new Error("Method not implemented.");
  }

  constructor() { }
}
