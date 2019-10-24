import { VersionComponent } from './version.component';
import { VersionService } from './version.service';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';



describe('VersionComponent', () => {
  let component: VersionComponent;
  let fixture: ComponentFixture<VersionComponent>;
  let mockVersionService;

  beforeEach(async(() => {
    mockVersionService = jasmine.createSpyObj(['getVersion']);
    TestBed.configureTestingModule({
      declarations: [ VersionComponent ],
      providers: [
        { provide: VersionService, useValue: mockVersionService }
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VersionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(fixture.componentInstance).toBeTruthy();
  });

  it('should set version', () => {
    mockVersionService.getVersion.and.returnValue('1.0.0.1');
    fixture.detectChanges();
    expect(component.version).toBe('1.0.0.0');
  });
});
