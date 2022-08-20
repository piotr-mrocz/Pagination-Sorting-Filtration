import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BackendSettings } from '../settings/backendSettings';
import { EndpointsUrl } from '../settings/endpointsUrl';
import { Country } from '../models/country';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class CountryService {
   countriesList: Country[] = [];

  constructor(
    private http: HttpClient,
    private backendSettings: BackendSettings,
    private endpointsUrl: EndpointsUrl) { }

    private getAllCountriesResponse() : Observable<Country[]> {
      var url = this.backendSettings.baseAddress + this.endpointsUrl.getAllCountriesEndpoint;
      return this.http.get<Country[]>(url);
    }

    getAllCountries() {
      return this.getAllCountriesResponse();
    }
}
