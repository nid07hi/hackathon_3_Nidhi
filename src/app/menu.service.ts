import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

 

@Injectable({
  providedIn: 'root'
})
export class MenuService {
  private apiUrl = 'http://example.com/api/menu'; // Replace with your API URL

 

  constructor(private http: HttpClient) { }

 

  getMenuItems(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}