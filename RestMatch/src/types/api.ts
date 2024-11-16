import {HttpMethods} from "@/types/enum";

export interface ApiRequestOptions {
  url: string;
  method: HttpMethods;
  body?: any;
}

export interface HttpsRequestOptions {
  url: string;
  req: any;
  res: any;
  method: HttpMethods;
  data?: any;
}