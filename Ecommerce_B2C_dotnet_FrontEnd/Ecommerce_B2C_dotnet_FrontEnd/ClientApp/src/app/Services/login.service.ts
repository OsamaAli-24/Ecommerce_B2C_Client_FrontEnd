import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  private heroesUrl = 'api/Login';
  private userUrl = 'https://localhost:44343/api/Login/';
  public token: any;

  constructor(private http: HttpClient) {}

  getLoginUser(params: any): Observable<any> {
    //let params = new HttpParams().set('userId', '1');
    //let headers = new HttpHeaders().set('Authorization', 'Test-Token');
    return this.http.get<any>(this.userUrl + 'LoginUser', params).pipe(
      tap((_) => this.log('Success')),
      catchError(this.handleError<any>('getLoginUser', []))
    );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
  private log(message: string) {
    console.log(`Error: ${message}`);
  }
}
