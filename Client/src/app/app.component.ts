import { Component, OnInit } from '@angular/core';
import { Country } from 'src/models/country';
import { CountryService } from 'src/services/country.service';
import { Subscription } from 'rxjs';
import { PagedResult } from 'src/models/pagedResult';
import { SieveModel } from 'src/models/sieveModel';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  countryIdSearch =""; 
  countryNameSearch =""; 
  countryCodeSearch =""; 
  capitalCitySearch =""; 
  continentSearch =""; 
  populationSearch =""; 
  
  countries: PagedResult<Country[]>;
  sieve: SieveModel = new SieveModel();

  constructor(private countryService: CountryService) {
    this.sieve.filters = "";
    this.sieve.page = 1;
    this.sieve.pageSize = 20;
    this.sieve.sorts = "";
  }

  ngOnInit() {
   this.getCountries();
  }

  consoleLogInformation() {
    console.log("countryIdSearch: " + this.countryIdSearch);
    console.log("countryNameSearch: " + this.countryNameSearch);
    console.log("countryCodeSearch: " + this.countryCodeSearch);
    console.log("capitalCitySearch: " + this.capitalCitySearch);
    console.log("continentSearch: " + this.continentSearch);
    console.log("populationSearch: " + this.populationSearch);
  }

  getCountries() {
    console.log(this.sieve);
    this.countryService.getAllCountries(this.sieve).subscribe((res: PagedResult<Country[]>) => {
      this.countries = res;
    });
  }

  onSearchIdChange(searchValue: KeyboardEvent): void {  
    if (searchValue.keyCode === 13) { // enter
      this.countryIdSearch = this.countryIdSearch.replace(/\s/g, '');

      this.sieve.filters += this.countryIdSearch != "" ? `id== ${this.countryIdSearch},` : "";
      this.sieve.page = 1;
      this.sieve.pageSize = 20;
      this.sieve.sorts += "id";
      this.getCountries();

      this.consoleLogInformation();
    }
  }

  onSearchNameChange(searchValue: KeyboardEvent): void {  
    if (searchValue.keyCode === 13) { // enter
      this.countryNameSearch = this.countryNameSearch.replace(/\s/g, '');

      this.sieve.filters += this.countryNameSearch != "" ? `countryName@=* ${this.countryNameSearch},` : "";
      this.sieve.page = 1;
      this.sieve.pageSize = 20;
      this.sieve.sorts += "countryName";
      this.getCountries();

      this.consoleLogInformation();
    }
  }

  onSearchCodeChange(searchValue: KeyboardEvent): void {  
    if (searchValue.keyCode === 13) { // enter
      this.countryCodeSearch = this.countryCodeSearch.replace(/\s/g, '');

      this.sieve.filters += this.countryCodeSearch != "" ? `countryCode@=* ${this.countryCodeSearch},` : "";
      this.sieve.page = 1;
      this.sieve.pageSize = 20;
      this.sieve.sorts += "countryCode";
      this.getCountries();

      this.consoleLogInformation();
    }
  }

  onSearchCapitalChange(searchValue: KeyboardEvent): void {  
    if (searchValue.keyCode === 13) { // enter
      this.capitalCitySearch = this.capitalCitySearch.replace(/\s/g, '');

      this.sieve.filters += this.capitalCitySearch != "" ? `capitalCity@=* ${this.capitalCitySearch},` : "";
      this.sieve.page = 1;
      this.sieve.pageSize = 20;
      this.sieve.sorts += "capitalCity";
      this.getCountries();

      this.consoleLogInformation();
    }
  }

  onSearchContinentChange(searchValue: KeyboardEvent): void {  
    if (searchValue.keyCode === 13) { // enter
      this.continentSearch = this.continentSearch.replace(/\s/g, '');

      this.sieve.filters += this.continentSearch != "" ? `continent== ${this.continentSearch},` : "";
      this.sieve.page = 1;
      this.sieve.pageSize = 20;
      this.sieve.sorts += "continent";
      this.getCountries();

      this.consoleLogInformation();
    }
  }

  onSearchPopulationChange(searchValue: KeyboardEvent): void {  
    if (searchValue.keyCode === 13) { // enter
      this.populationSearch = this.populationSearch.replace(/\s/g, '');

      this.sieve.filters += this.populationSearch != "" ? `population== ${this.populationSearch},` : "";
      this.sieve.page = 1;
      this.sieve.pageSize = 20;
      this.sieve.sorts += "population";
      this.getCountries();

      this.consoleLogInformation();
    }
  }
}
