import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { ItemsComponent } from './items/items.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { HomepageComponent } from './homepage/homepage.component';
import { NavHotelComponent } from './nav-hotel/nav-hotel.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    ItemsComponent,
    CheckoutComponent,
    HomepageComponent,
    NavHotelComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
