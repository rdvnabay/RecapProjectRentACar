import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Brand } from 'src/app/models/brand';
import { BrandService } from 'src/app/services/brand.service';

@Component({
  selector: 'app-brand-list',
  templateUrl: './brand-list.component.html',
  styleUrls: ['./brand-list.component.css'],
})
export class BrandListComponent implements OnInit {
  brands: Brand[] = [];
  constructor(
    private brandService: BrandService,
    private router: Router,
    private toastrService: ToastrService
  ) {}

  ngOnInit(): void {
    this.getAll();
  }

  getAll() {
    this.brandService.getAll().subscribe(response => {
      this.brands = response.data;
    });
  }

  delete(brandId: number) {
    this.brandService.delete(brandId).subscribe(response => {
      this.toastrService.warning('Marka silindi', 'Başarılı');
      this.router.navigateByUrl('admin');
    });
  }
}
