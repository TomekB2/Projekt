import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AppComponent } from '../app.component';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  readonly ROOT_URL = 'http://localhost:5069/';

  lang = localStorage.getItem('lang') || "en";;
  message: any;
  cookies: any;
  http: any;

  constructor(http: HttpClient, public lanng: AppComponent) {
    http.get<MOTD>(this.ROOT_URL + 'MOTD?lang=' + this.lang).subscribe(result2 => {
      this.message = result2;
    }, error => console.error(error));
    http.get<Cookies>(this.ROOT_URL + 'Cookies?lang=' + this.lang).subscribe(result => {
      this.cookies = result;
        let cc = window as any;
        cc.cookieconsent.initialise({
          palette: {
            popup: {
              background: "#164969"
            },
            button: {
              background: "#ffe000",
              text: "#164969"
            }
          },
          theme: "classic",
          content: {
            message: this.cookies.message,
            dismiss: this.cookies.dismiss,
            link: this.cookies.link,
            href: this.cookies.href
          }
        });
    }, error => console.error(error));
  }
}

interface MOTD {
  message: string;
}
interface Cookies {
  message: any;
  dismiss: any;
  link: any;
  href: any;
}
