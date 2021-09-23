import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, AbstractControl } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { Observable } from 'rxjs';
import { LoginParams } from 'src/app/_models/LoginParams';
import { LoginService } from '../Services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  @Input() login?: Observable<any>;
  //logindata: LoginParams;
  public loginparam: LoginParams = new LoginParams();
  loginForm = this.fb.group({
    Email: ['', [Validators.required]],
    Password: ['', [Validators.required]],
  });
  constructor(
    private fb: FormBuilder,
    private loginService: LoginService //private logindata: LoginParams
  ) {}
  onSubmit() {
    console.warn(this.loginForm.value);
    this.loginparam.Email = this.loginForm.value.Email;
    this.loginparam.Password = this.loginForm.value.Password;
    this.getLogin(this.loginForm.value);
  }
  //LoginParams;
  getLogin(data: LoginParams): void {
    //debugger;
    this.loginService
      .getLoginUser(data)
      .subscribe((data: any) => (this.login = data));
  }
  ngOnInit(): void {}
}
