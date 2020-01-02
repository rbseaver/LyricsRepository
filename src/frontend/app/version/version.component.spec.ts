import { IVersionService } from './IVersionService';
import { VersionComponent } from './version.component';
import { VersionService } from './version.service';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { Observable, of } from 'rxjs';

describe('VersionComponent', () => {
  let component;
  let mockVersionService;

  beforeEach(async(() => {
    mockVersionService = {
      getVersion: jest.fn()
    }

    TestBed.configureTestingModule({
      declarations: [ VersionComponent ],
      providers: [
        { provide: VersionService, useValue: mockVersionService }
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    component = TestBed.createComponent(VersionComponent).componentInstance;
  });

  it('should get and display version', async(() => {
    mockVersionService.getVersion.mockReturnValueOnce(of('1.0.0.0'));
    component.ngOnInit();
    component.version.subscribe(v => expect(v).toBe('1.0.0.0'));
  }));
});
