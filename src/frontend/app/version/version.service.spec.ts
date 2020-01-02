import { VersionService } from './version.service';
import { of } from 'rxjs';
import { TestBed } from '@angular/core/testing';
import { VersionApiService } from 'app/api/version-api.service';



describe('VersionService', () => {
  let mockVersionApiService;
  let service;

  beforeEach(() => {
    mockVersionApiService = {
      get: jest.fn()
    };
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
    mockVersionApiService.get.mockReturnValue(of('1.0.0.0'));

    service.getVersion().subscribe((result) => expect(result).toBe('1.0.0.0'));
  });
});
