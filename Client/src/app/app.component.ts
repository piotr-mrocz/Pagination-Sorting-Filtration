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
  countryNameSearch =""; 
  countries: PagedResult<Country[]>;
  sieve: SieveModel = new SieveModel();

  constructor(private countryService: CountryService) {
  }

  ngOnInit() {
   this.getCountries();
  }

  getCountries() {
    console.log(this.sieve);
    this.countryService.getAllCountries(this.sieve).subscribe((res: PagedResult<Country[]>) => {
      this.countries = res;
    });
  }

  onSearchChange(searchValue: KeyboardEvent): void {  
    if (searchValue.keyCode === 13) { // enter
      this.countryNameSearch = this.countryNameSearch.replace(/\s/g, '');

      this.sieve.filters = `countryName@=* ${this.countryNameSearch},`;
      this.sieve.page = 1;
      this.sieve.pageSize = 20;
      this.sieve.sorts = "countryName";
      this.getCountries();
    }
  }
}
