import { HttpClient } from '@angular/common/http';
import { Subscription } from "rxjs";
import { Router, RouterEvent, NavigationEnd } from '@angular/router';
import { Component, OnInit, OnDestroy } from "@angular/core";
import {
  NgcCookieConsentService,
  NgcNoCookieLawEvent,
  NgcInitializingEvent,
  NgcStatusChangeEvent,
  NgcInitializationErrorEvent,
} from "ngx-cookieconsent";
import { Injectable } from '@angular/core';


@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
})
export class AppComponent {
 


@Injectable({
  providedIn: "root"
})
  SeqNr: string = "pl";

  constructor() { }

  setValue(value: string) {
    this.SeqNr = value;
  }

  getValue() {
    return this.SeqNr;
  }
}

