import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BackendSettings } from '../settings/backendSettings';
import { EndpointsUrl } from '../settings/endpointsUrl';
import { Country } from '../models/country';
import { Observable } from 'rxjs';
import { PagedResult } from 'src/models/pagedResult';
import { SieveModel } from 'src/models/sieveModel';

@Injectable({
  providedIn: 'root'
})

export class CountryService {
   countriesList: PagedResult<Country[]>;

  constructor(
    private http: HttpClient,
    private backendSettings: BackendSettings,
    private endpointsUrl: EndpointsUrl) { }

    private getAllCountriesResponse(sieve: SieveModel) : Observable<PagedResult<Country[]>> {
      var url = this.backendSettings.baseAddress + this.endpointsUrl.getAllCountriesEndpoint;
      return this.http.post<PagedResult<Country[]>>(url, sieve);
    }

    getAllCountries(sieve: SieveModel) {
      return this.getAllCountriesResponse(sieve);
    }
}
