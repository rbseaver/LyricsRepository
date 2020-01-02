import { Observable } from 'rxjs';
export interface IVersionService {
  getVersion(): Observable<string>;
}
