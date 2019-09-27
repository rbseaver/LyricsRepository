import { TestBed } from '@angular/core/testing';

import { VersionService } from './version.service';
import { VersionApiService } from 'app/api/version-api.service';


describe('VersionService', () => {
  let mockVersionApiService;
  beforeEach(() => {
    mockVersionApiService = jasmine.createSpyObj(['get']);
    TestBed.configureTestingModule({
      providers:  [
        { provide: VersionApiService, useClass: mockVersionApiService }
      ]
    });
  });

  it('should be created', () => {
    const service: VersionService = TestBed.get(VersionService);
    expect(service).toBeTruthy();
  });

  it('should call api with correct url', () => {
    const service: VersionService = TestBed.get(VersionService);
    mockVersionApiService.get.and.returnValue('1.0.0.0');

    const version = service.getVersion();

    expect(version).toBe('1.0.0.0');
  });
});
