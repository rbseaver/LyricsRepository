import { environment } from 'environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VersionApiService {
  private baseUrl: string = environment.baseUrl;

  constructor(private http: HttpClient) { }

  public get(): Observable<string> {
    return this.http.get<string>(`${this.baseUrl}/version`);
  }
}
