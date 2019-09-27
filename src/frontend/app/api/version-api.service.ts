import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { defaults } from 'appsettings';
import { environment } from 'environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VersionApiService {
  private baseUrl: string = environment.baseUrl;

  constructor(private http: HttpClient) { }

  public get(): Observable<string> {
    return this.http.get<string>(`${this.baseUrl}/version`).pipe();
  }
}
