import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardsComponent } from './cards/cards.component';
import {MatCardModule} from '@angular/material/card';
import {MatChipsModule} from '@angular/material/chips';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    CardsComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatChipsModule,
    RouterModule,
    HttpClientModule
  ],
  exports: [
    CardsComponent
  ]
})
export class ContentListModule { }
