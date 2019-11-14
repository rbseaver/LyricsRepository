import { VersionComponent } from './version.component';
import { VersionService } from './version.service';
import { async, ComponentFixture, fakeAsync, TestBed, tick } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { of } from 'rxjs';

describe('VersionComponent', () => {
  let component: VersionComponent;
  let mockVersionService;

  beforeEach(async(() => {

    TestBed.configureTestingModule({
      declarations: [ VersionComponent ],
      providers: [
        { provide: VersionService, useValue: mockVersionService }
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    mockVersionService = jasmine.createSpyObj(['getVersion']);
    component = new VersionComponent(mockVersionService);
  });

  it('should set version', async(() => {
    mockVersionService.getVersion.and.returnValue(of('1.0.0.0'));

    component.ngOnInit();

    expect(component.version).toBe('1.0.0.0');
  }));
});
