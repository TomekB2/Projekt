import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  lang = localStorage.getItem('lang') || "en";
  collapse() {
    this.isExpanded = false;
  }
  temp: any;
  public values = [
    {
      key: "English",
      value: "en"
    },
    {
      key: "Polski",
      value: "pl"
    }
  ]
  public values2 = [
    {
      key: "Polski",
      value: "pl"
    },
    {
      key: "English",
      value: "en"
    }
  ]

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  public sections: Sections[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Sections[]>(baseUrl + 'Sections?lang=' + this.lang).subscribe(result => {
      this.sections = result;
    }, error => console.error(error));
  }

  changeLang(lang2: any)
  {
    localStorage.setItem('lang', lang2);
    window.location.reload(); 
  }
}

interface Sections {
  id: number;
  summary: string;
  type: string;
}

