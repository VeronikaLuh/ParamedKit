import {HttpMethods} from "@/types/enum";

export interface ApiRequestOptions {
  url: string;
  method: HttpMethods;
  body?: any;
}

export interface HttpsRequestOptions {
  url: string;
  req: any;
  method: HttpMethods;
  data?: any;
}