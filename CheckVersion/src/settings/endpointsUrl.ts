import { Injectable } from "@angular/core";

@Injectable({
  providedIn: 'root'
})

export class EndpointsUrl {
  public readonly getAllCountriesEndpoint = "api/Country/GetAllCountries";
}
