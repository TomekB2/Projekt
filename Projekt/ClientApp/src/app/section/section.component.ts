import { Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';


@Component({
  selector: 'app-section-component',
  templateUrl: './section.component.html',
})
export class SectionComponent {

  public fields2: SectionFields[] = [];
  public fields: FormlyFieldConfig[] = [];
  public pageField: any;
  public wynik2: any
  public section: any;
  public section2: any;
  lang = localStorage.getItem('lang') || "en";
  id: any
  http2: any
  paramsSubscription: any;

  constructor(private http: HttpClient, @Inject('BASE_URL') public baseUrl: string, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id');
      http.get<Sections>(baseUrl + 'Sections?lang=' + this.lang).subscribe(result => {
        this.section = result
      }, error => console.error(error));
    });
    this.router.routeReuseStrategy.shouldReuseRoute = () => false;
    http.get<SectionFields[]>(baseUrl + 'SectionField?id=' + this.id + '&lang=' + this.lang).subscribe(result => {
      this.fields2 = result;
      this.fields = this.fields2;
      this.section2 = this.section[this.id - 1].summary;
    }, error => console.error(error));
  }

  form = new FormGroup({});
  model = { };
  link: any;

  onSubmit(model: any) {
    if (this.form.valid) {
      if (this.id == 2) {
        this.link = this.baseUrl + 'Alkohol?gesPocza=' + this.form.get('gesPocza')?.getRawValue() + '&geskon=' + this.form.get('geskon')?.getRawValue();
        this.http.post<Alkohol>(this.link, null).subscribe(data => {
          this.wynik2 = data.wynik;
          this.pageField = this.form.get('wynik');
          this.pageField.setValue(this.wynik2);
        });
        }
        if (this.id == 1) {
          this.link = this.baseUrl + 'Nagazowanie?temp=' + this.form.get('temppiwa')?.getRawValue() + '&co=' + this.form.get('pozCO')?.getRawValue() + '&ilo=' + this.form.get('ilPiwa')?.getRawValue();
          this.http.post<Nagazowanie>(this.link, null).subscribe(data => {
            this.wynik2 = data.wynik;
            this.pageField = this.form.get('wynik');
            this.pageField.setValue(this.wynik2);
          });
        }
        if (this.id == 3) {
          this.link = this.baseUrl + 'Refraktometr?gesPocza=' + this.form.get('gesPocz')?.getRawValue() + '&gezmie=' + this.form.get('zmigest')?.getRawValue()
          this.http.post<Refraktometr>(this.link, null).subscribe(data => {
            this.wynik2 = data.wynik;
            this.pageField = this.form.get('wynik');
            this.pageField.setValue(this.wynik2);
          });
        }
      }
    }
  }


interface SectionFields {
  key: string;
  type: string;
  templateOptions: TemplateOptions;
}
interface TemplateOptions {
  type: string;
  label: string;
  placeholder: string;
  required: boolean;
}
interface Alkohol {
  wynik: number;
}
interface Nagazowanie {
  wynik: number;
}

interface Refraktometr {
  wynik: number;
}
interface Sections {
  id: number;
  summary: string;
  type: string;
}

