export class LoginResults {
  Email: string;
  Password: string;
  Id: number;
  FirstName: string;
  LastName: string;
  ImageName: string;
  PhoneNumber: string;
  RegistrationDate: any;
  DateOfBirth: any;
  Gender: GenderType;
  Role: string;
  IsActive: boolean;
  IsDelete: boolean;
  City: string;
  State: string;
  Country: string;
  Token: string;

  constructor() {
    this.Email = '';
    this.Password = '';
    this.Id = 1;
    this.FirstName = '';
    this.LastName = '';
    this.ImageName = '';
    this.PhoneNumber = '';
    this.RegistrationDate = null;
    this.DateOfBirth = null;
    this.Gender = 1;
    this.Role = '';
    this.IsActive = true;
    this.IsDelete = true;
    this.City = '';
    this.State = '';
    this.Country = '';
    this.Token = '';
  }
}
export enum GenderType {
  NA = 0,
  Male = 1,
  Female = 2,
}
