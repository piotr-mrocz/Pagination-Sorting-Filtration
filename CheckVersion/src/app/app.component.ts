import { Component, OnInit } from '@angular/core';
import { Country } from 'src/models/country';
import { CountryService } from 'src/services/country.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'CheckVersion';
  countries: Country[];

  private subscription: Subscription;

  constructor(private countryService: CountryService) {
  }

  ngOnInit() {
   this.getCountries();
  }

  getCountries() {
    this.countryService.getAllCountries().subscribe((res: Country[]) => {
      this.countries = res;
    });
  }
}
