import { TestBed } from '@angular/core/testing';

import { VersionService } from './version.service';
import { VersionApiService } from 'app/api/version-api.service';


describe('VersionService', () => {
  let mockVersionApiService;
  let service;

  beforeEach(() => {
    mockVersionApiService = jasmine.createSpyObj(['get']);
    TestBed.configureTestingModule({
      providers:  [
        { provide: VersionApiService, useValue: mockVersionApiService }
      ]
    });
    service = TestBed.get(VersionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should retrieve version', () => {
    mockVersionApiService.get.and.returnValue('1.0.0.0');

    const version = service.getVersion();

    expect(version).toBe('1.0.0.0');
  });
});
