import {NextResponse} from 'next/server'
import {HttpMethods} from "@/types/enum";
import ApiService from "@/services/api.service";

export async function GET(req: Request) {
  try {
    const { searchParams } = new URL(req.url);

    const queryParams = new URLSearchParams();

    const paramsToInclude = ["location", "lowestPrice", "highestPrice", "sortOrder", "pageNumber", "cuisine"];
    paramsToInclude.forEach((param) => {
      const value = searchParams.get(param);
      if (value) queryParams.append(param, value);
    });

    const apiUrl = `${process.env.NEXT_PUBLIC_BACKEND_URL}/Restaurants?${queryParams.toString()}`;

    const response = await ApiService.makeHttpsRequest({
      url: apiUrl,
      method: HttpMethods.GET,
      req,
    });

    return NextResponse.json({ data: response });
  } catch (error) {
    console.error("Error fetching restaurants:", error);

    return NextResponse.json(
      { error: "Failed to fetch restaurant data" },
      { status: 500 }
    );
  }
}

export async function POST(req: Request) {
  const response = await ApiService.makeHttpsRequest({
    url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Restaurants`,
    method: HttpMethods.POST,
    req: req
  });

  return NextResponse.json({data: response});
}

