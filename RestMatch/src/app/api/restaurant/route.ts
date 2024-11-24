import {NextResponse} from 'next/server'
import {HttpMethods} from "@/types/enum";
import ApiService from "@/services/api.service";

export async function GET(req: Request) {
  const response = await ApiService.makeHttpsRequest({
    url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Restaurants`,
    method: HttpMethods.GET,
    req: req
  });

  return NextResponse.json({data: response});
}

export async function POST(req: Request) {
  const response = await ApiService.makeHttpsRequest({
    url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Restaurants`,
    method: HttpMethods.POST,
    req: req
  });

  return NextResponse.json({data: response});
}

export async function PUT(req: Request, {params}: { params: { id: string } }) {
  const id = parseInt(params.id, 10);

  const response = await ApiService.makeHttpsRequest({
    url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Restaurants/${id}`,
    method: HttpMethods.PUT,
    req: req
  });

  return NextResponse.json({data: response});
}

export async function DELETE(req: Request, {params}: { params: { id: string } }) {
  const id = parseInt(params.id, 10);

  const response = await ApiService.makeHttpsRequest({
    url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Restaurants/${id}`,
    method: HttpMethods.DELETE,
    req: req
  });

  return NextResponse.json({data: response});
}